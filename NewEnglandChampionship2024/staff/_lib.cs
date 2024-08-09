#include "../lib/_constants.cs"

Define("ScrambleSpeedWeight",
       [Tuple(_333, 3),
        Tuple(_222, 3),
        Tuple(_444, 5),
        Tuple(_555, 5),
        Tuple(_666, 8),
        Tuple(_777, 8),
        Tuple(_333bf, 1),
        Tuple(_333oh, 1),
        Tuple(_sq1, 5),
        Tuple(_clock, 5),
        Tuple(_pyram, 3),
        Tuple(_minx, 8),
        Tuple(_skewb, 3)])

Define("ScrambleReferences",
        [Tuple(_333, 20s),
         Tuple(_222, 8s),
         Tuple(_444, 1:00s),
         Tuple(_555, 1:30s),
         Tuple(_666, 3:00s),
         Tuple(_777, 2:30s),
         Tuple(_sq1, 30s),
         Tuple(_clock, 12s),
         Tuple(_pyram, 8s),
         Tuple(_minx, 1:30s),
         Tuple(_skewb, 8s)])

Define("EventsToScramblingEvents",
       [Tuple(_333, _333),
        Tuple(_222, _222),
        Tuple(_444, _444),
        Tuple(_555, _555),
        Tuple(_666, _666),
        Tuple(_777, _777),
        Tuple(_sq1, _sq1),
        Tuple(_clock, _clock),
        Tuple(_pyram, _pyram),
        Tuple(_minx, _minx),
        Tuple(_skewb, _skewb),
        Tuple(_333bf, _333),
        Tuple(_333oh, _333),
        Tuple(_333mbf, _333),
        Tuple(_444bf, _444),
        Tuple(_555bf, _555)])

Define("JobQuota",
       Switch(Length(RegisteredEvents({1, Person})), [
         Tuple(1, 2),
         Tuple(2, 3),
         Tuple(3, 4),
         Tuple(4, 5),
         Tuple(5, 6),
         Tuple(6, 7),
         Tuple(7, 7),
         Tuple(8, 8),
         Tuple(9, 8),
         Tuple(10, 9),
         Tuple(11, 9),
         Tuple(12, 10),
         Tuple(13, 10)]))

Define("JobQuotaForRound",
       Switch({1, Number}, [
         Tuple(1, 1),
         Tuple(2, 2),
         Tuple(3, 2),
         Tuple(4, 3),
         Tuple(5, 3)]))

# TODO: Move to prep/
SetProperty(Persons(IsStaff(Arg<Person>())), "pref-judge", 0)
SetProperty(Persons(IsStaff(Arg<Person>())), "pref-scrambler", 50)
SetProperty(Persons(IsStaff(Arg<Person>())), "pref-runner", 50)
SetProperty(Persons(IsDelegate(Arg<Person>())), "pref-Delegate", 100)

# 1: Round
# 2: Event
# 3: Number of groups
Define("StaffScorers",
       [
         # High-order scorers: scorers to determine who works.
         # Non-staff: prioritized up to quota (5000 penalty per job past quota)
         ComputedWeightScorer(If(IsStaff(Arg<Person>()),
                                 0,
                                 If((NumJobs(Arg<Person>()) < JobQuota(Arg<Person>())),
                                    5000, (5000 * (JobQuota(Arg<Person>()) - NumJobs(Arg<Person>()))))),
                              ["judge", "runner", "scrambler"]),
         # Non-staff: prefer staffing right after competing (+500)
         PersonPropertyScorer(And(Not(IsStaff(Arg<Person>())),
                                  CompetingIn({2, Event}),
                                  (Mod((GroupNumber(Arg<Group>()) -
                                        GroupNumber(AssignedGroup({1, Round}, Arg<Person>()))),
                                       {3, Number}) == 1)),
                              500),
         # Non-staff: 1000 deduction if you've already staffed this event.
         ComputedWeightScorer(If(Not(IsStaff(Arg<Person>())),
                                 (NumJobsInRound(Arg<Person>(), {1, Round}) * -1000), 0),
                              ["judge", "runner", "scrambler"]),
         # Non-staff: 500 deduction if you're not in this event.
         PersonPropertyScorer(And(Not(IsStaff(Arg<Person>())),
                                  Not(CompetingIn({2, Event}))),
                              -500),
         # Staff: preferred up to per-event quota (+7000)
         PersonPropertyScorer(And(IsStaff(Arg<Person>()),
                                  (StaffTeam(Arg<Person>()) == Stage(Arg<Group>())),
                                  (NumJobsInRound(Arg<Person>(), {1, Round}) < JobQuotaForRound({3, Number}))),
                              7000),
         # Staff: demotion for staffing on the wrong stage (-10000)
         PersonPropertyScorer(And(IsStaff(Arg<Person>()),
                                  Not((StaffTeam(Arg<Person>()) == Stage(Arg<Group>())))), -10000),
         #
         # Second order scorers: put people on the right stages.
         PersonPropertyScorer((Stage(AssignedGroup({1, Round}, Arg<Person>())) == Stage(Arg<Group>())), 100),
         # 
         # Third order scorers: decide which jobs to give people.
         SolvingSpeedScorer(Switch({2, Event}, EventsToScramblingEvents()),
                            Switch(Switch({2, Event}, EventsToScramblingEvents()), ScrambleReferences()),
                            Switch({2, Event}, ScrambleSpeedWeight()),
                            ["scrambler"]),
         ComputedWeightScorer(If(Or((Age(Arg<Person>()) > 16),
                                    IsStaff(Arg<Person>())),
                                 16, Age(Arg<Person>())), ["runner"]),
         ComputedWeightScorer(If(IsStaff(Arg<Person>()), -5, 0), ["judge"]),
         PreferenceScorer(10, "pref-", 10, ["judge", "runner", "scrambler", "Delegate"])
       ])

# Args:
# 1: Round
# 2: Eligible people (besides staff and competitors in that round)
# 3: Jobs per stage
# 4: Num groups
Define("RoundOneStaffAssignments",
           AssignStaff(
             {1, Round},
             true,
             Persons(And(Or(CompetingInRound({1, Round}, Arg<Person>()),
                            IsStaff(Arg<Person>()),
                            In(Arg<Person>(), {2, Array<Person>()})),
                         Not((Arg<Person>() == 2022ALCO02)))),
             {3, Array<AssignmentJob>},
             StaffScorers({1, Round}, EventForRound({1, Round}), {4, Number})
           ))

Define("Judges", Job("judge", {1, Number}))
Define("Scramblers", Job("scrambler", {1, Number}))
Define("Runners", Job("runner", {1, Number}))
Define("Delegates", Job("Delegate", {1, Number}, eligibility=Or(HasRole(DELEGATE), HasRole(TRAINEE_DELEGATE))))
