#include "_lib.cs"

Map([_777-r1, _minx-r1, _666-r1, _clock-r1, _sq1-r1, _333bf-r1,
     _333-r1, _444-r1, _pyram-r1, _555-r1, _skewb-r1,
     _222-r1, _333oh-r1],
    AssignGroups(Arg<Round>(),
                 RoundOneAssignmentSets(EventForRound(Arg<Round>()),
                                        (Length(Groups(Arg<Round>())) * 0.7)),
                 GroupScorers()))
