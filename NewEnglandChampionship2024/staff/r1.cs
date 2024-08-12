#include "_lib.cs"

RoundOneStaffAssignments(_777-r1, [], [Judges(8), Scramblers(3), Runners(1), Delegates(1)], 2)
RoundOneStaffAssignments(_minx-r1, Persons(CompetingIn(_777)),
                         [Judges(12), Scramblers(3), Runners(2), Delegates(1)], 3)
RoundOneStaffAssignments(_666-r1,
                         Persons(Or(CompetingIn(_777),
                                    CompetingIn(_minx))),
                         [Judges(10), Scramblers(3), Runners(2), Delegates(1)], 2)
RoundOneStaffAssignments(_clock-r1,
                         Persons(Or(CompetingIn(_minx),
                                    CompetingIn(_666))),
                         [Judges(13), Scramblers(3), Runners(3), Delegates(1)], 2)
RoundOneStaffAssignments(_sq1-r1,
                         Persons(Or(CompetingIn(_666),
                                    CompetingIn(_clock))),
                         [Judges(13), Scramblers(3), Runners(3), Delegates(1)], 2)
RoundOneStaffAssignments(_333bf-r1,
                         Persons(Or(CompetingIn(_clock),
                                    CompetingIn(_sq1))),
                         [Judges(10), Scramblers(2), Runners(2), Delegates(1)], 2)

RoundOneStaffAssignments(_333-r1, [],
                         [Judges(14), Scramblers(3), Runners(4), Delegates(1)], 5)
RoundOneStaffAssignments(_444-r1, Persons(CompetingIn(_333)),
                         [Judges(14), Scramblers(3), Runners(3), Delegates(1)], 3)
RoundOneStaffAssignments(_pyram-r1, Persons(CompetingIn(_555)),
                         [Judges(14), Scramblers(3), Runners(3), Delegates(1)], 3)
RoundOneStaffAssignments(_555-r1,
                         Persons(Or(CompetingIn(_pyram),
                                    CompetingIn(_skewb))),
                         [Judges(12), Scramblers(4), Runners(2), Delegates(1)], 2)
RoundOneStaffAssignments(_skewb-r1, Persons(CompetingIn(_555)),
                         [Judges(14), Scramblers(3), Runners(4), Delegates(1)], 3)
RoundOneStaffAssignments(_222-r1, [],
                         [Judges(14), Scramblers(3), Runners(4), Delegates(1)], 4)
RoundOneStaffAssignments(_333oh-r1, [],
                         [Judges(14), Scramblers(3), Runners(3), Delegates(1)], 3)
