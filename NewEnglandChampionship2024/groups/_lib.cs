#include "../lib/_constants.cs"
#include "../lib/_staff_teams.cs"

Define("RoundOneAssignmentSets",
       [AssignmentSet("Top", (PsychSheetPosition({1, Event}) < {2, Number}), (Stage() == RED), featured=true),
        AssignmentSet("Delegates", IsDelegate(Arg<Person>()), true),
        AssignmentSet("Data", (StaffTeam(Arg<Person>()) == DATA), (Stage() == RED)),
        AssignmentSet("Everyone", true, true)])

Define("GroupScorers",
       Concat(Map(Stages(), ByFilters((StaffTeam(Arg<Person>()) == Arg<String>()),
                                      (Stage() == Arg<String>()), 10)),
              [ByMatchingValue(FirstName(), -5)]))
