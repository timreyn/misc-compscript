#include "_lib.cs"

RoundOneStaffAssignments(_777-r1, [], [Judges(8), Scramblers(3, _777), Runners(1), Delegates(1)], 2)
RoundOneStaffAssignments(_minx-r1, Persons(CompetingIn(_777)),
                         [Judges(12), Scramblers(3, _minx), Runners(2), Delegates(1)], 3)
RoundOneStaffAssignments(_666-r1,
                         Persons(Or(CompetingIn(_777),
                                    CompetingIn(_minx))),
                         [Judges(10), Scramblers(3, _666), Runners(2), Delegates(1)], 2)
RoundOneStaffAssignments(_clock-r1,
                         Persons(Or(CompetingIn(_minx),
                                    CompetingIn(_666))),
                         [Judges(13), Scramblers(3, _clock), Runners(3), Delegates(1)], 2)
RoundOneStaffAssignments(_sq1-r1,
                         Persons(Or(CompetingIn(_666),
                                    CompetingIn(_clock))),
                         [Judges(13), Scramblers(3, _sq1), Runners(3), Delegates(1)], 2)
RoundOneStaffAssignments(_333bf-r1,
                         Persons(Or(CompetingIn(_clock),
                                    CompetingIn(_sq1))),
                         [Judges(10), Scramblers(2, _333bf), Runners(2), Delegates(1)], 2)

