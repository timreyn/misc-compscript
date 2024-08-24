Map(Events(),
    All(Arg<Event>(),
      Table(
        Sort(Persons(And(Registered(),
                         Not(CompetingIn(Arg<Event>())),
                         Not(IsNull(PersonalBest(Arg<Event>(), Arg<Person>()))))),
             PersonalBest(Arg<Event>(), Arg<Person>())),
        [Column("Name", Name()),
         Column("PR", PersonalBest(Arg<Event>(), Arg<Person>()))])))
