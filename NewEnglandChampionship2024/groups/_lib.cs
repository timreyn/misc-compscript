#include "../lib/_constants.cs"
#include "../lib/_staff_teams.cs"

Define("RoundOneAssignmentSets",
       [AssignmentSet("Delegates", HasRole(DELEGATE), true),
        AssignmentSet("Data", (StaffTeam(Arg<Person>()) == DATA), (Stage() == RED)),
        AssignmentSet("Everyone", true, true)])

Define("GroupScorers",
       Map(Stages(), ByFilters((StaffTeam(Arg<Person>()) == Arg<String>()),
                               (Stage() == Arg<String>()), 10)))
