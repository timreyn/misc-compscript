#include "../lib/_staff_teams.cs"

Table(
  Sort(Persons(Registered()), StaffTeam(Arg<Person>())),
  [
    Column("Name", Name()),
    Column("Team", StaffTeam(Arg<Person>())),
    Column("judge", NumJobs("judge")),
    Column("scrambler", NumJobs("scrambler")),
    Column("runner", NumJobs("runner")),
    Column("Delegate", NumJobs("Delegate")),
    Column("total", NumJobs()),
    Column("events", Length(RegisteredEvents()))])
