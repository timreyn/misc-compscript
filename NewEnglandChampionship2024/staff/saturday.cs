#include "_lib.cs"

RoundOneStaffAssignments(_333-r1, [],
                         [Judges(14), Scramblers(3, _333), Runners(4), Delegates(1)], 5)
RoundOneStaffAssignments(_444-r1, Persons(CompetingIn(_333)),
                         [Judges(14), Scramblers(3, _444), Runners(3), Delegates(1)], 3)
RoundOneStaffAssignments(_pyram-r1, Persons(CompetingIn(_555)),
                         [Judges(14), Scramblers(3, _pyram), Runners(3), Delegates(1)], 3)
RoundOneStaffAssignments(_555-r1,
                         Persons(Or(CompetingIn(_pyram),
                                    CompetingIn(_skewb))),
                         [Judges(12), Scramblers(4, _555), Runners(2), Delegates(1)], 2)
RoundOneStaffAssignments(_skewb-r1, Persons(CompetingIn(_555)),
                         [Judges(14), Scramblers(3, _skewb), Runners(4), Delegates(1)], 3)
