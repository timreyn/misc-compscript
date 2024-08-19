Table(
    Map(Events(), Tuple(Arg<Event>(), Persons(CompetingIn(Arg<Event>())))),
    Concat([Column("Event", EventId(First(Arg<Tuple<Event, Array<Person>>>())))],
           Map(Events(),
               Column(EventId(Arg<Event>()),
                      Length(Filter(Second(Arg<Tuple<Event, Array<Person>>>()),
                                    CompetingIn(Arg<Event>())))))))
