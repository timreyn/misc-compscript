#include "../lib/_constants.cs"

#define MAIN "Main Hall"

CreateRoom(MAIN, "#000000")
CreateRoom(RED, "#ff0000")
CreateRoom(BLUE, "#0000ff")
CreateRoom(GREEN, "#008000")

# Friday
CreateMiscActivity("Check-in", "other-checkin", MAIN, 2024-08-23T12:00, 2024-08-23T16:00)
CreateMiscActivity("New Competitor Tutorial", "other-tutorial", GREEN, 2024-08-23T12:30, 2024-08-23T12:45)
Map(Stages(), CreateGroups(_777-r1, 2, 2024-08-23T12:45, 2024-08-23T13:30))
Map(Stages(), CreateGroups(_minx-r1, 2, 2024-08-23T13:30, 2024-08-23T14:15))
Map(Stages(), CreateGroups(_666-r1, 2, 2024-08-23T14:15, 2024-08-23T15:00))
Map(Stages(), CreateGroups(_clock-r1, 2, 2024-08-23T15:00, 2024-08-23T15:45))
Map(Stages(), CreateGroups(_sq1-r1, 2, 2024-08-23T15:45, 2024-08-23T16:30))
Map(MainStages(), CreateGroups(_333bf-r1, 2, 2024-08-23T16:30, 2024-08-23T17:15))
Map(MainStages(), CreateGroups(_777-r2, 1, 2024-08-23T17:15, 2024-08-23T17:40))
Map(MainStages(), CreateGroups(_minx-r2, 1, 2024-08-23T17:40, 2024-08-23T18:00))

# Saturday
CreateMiscActivity("Check-in", "other-checkin", MAIN, 2024-08-24T08:00, 2024-08-24T12:00)
CreateMiscActivity("New Competitor Tutorial", "other-tutorial", GREEN, 2024-08-24T08:40, 2024-08-24T09:00)
Map(Stages(), CreateGroups(_333-r1, 5, 2024-08-24T09:00, 2024-08-24T10:40))
Map(Stages(), CreateGroups(_444-r1, 3, 2024-08-24T10:40, 2024-08-24T11:40))
CreateMiscActivity("Lunch", "other-lunch", MAIN, 2024-08-24T11:40, 2024-08-24T12:40)
Map(Stages(), CreateGroups(_pyram-r1, 4, 2024-08-24T12:40, 2024-08-24T14:00))
Map(Stages(), CreateGroups(_555-r1, 3, 2024-08-24T14:00, 2024-08-24T15:00))
Map(Stages(), CreateGroups(_skewb-r1, 3, 2024-08-24T15:00, 2024-08-24T16:00))
Map(Stages(), CreateGroups(_333-r2, 3, 2024-08-24T16:00, 2024-08-24T16:45))
Map(MainStages(), CreateGroups(_444-r2, 2, 2024-08-24T16:45, 2024-08-24T17:30))
Map(MainStages(), CreateGroups(_pyram-r2, 2, 2024-08-24T17:30, 2024-08-24T18:00))
CreateMiscActivity("States Cup", "other-misc", RED, 2024-08-24T18:00, 2024-08-24T19:00)
CreateMiscActivity("The State of Cube New England", "other-misc", RED, 2024-08-24T19:00, 2024-08-24T19:30)

# Sunday
CreateMiscActivity("Check-in", "other-checkin", MAIN, 2024-08-25T08:00, 2024-08-25T08:30)
Map(Stages(), CreateGroups(_222-r1, 4, 2024-08-25T08:30, 2024-08-25T09:45))
Map(Stages(), CreateGroups(_333oh-r1, 3, 2024-08-25T09:45, 2024-08-25T10:30))
Map(MainStages(), CreateGroups(_333-r3, 2, 2024-08-25T10:30, 2024-08-25T11:00))
Map(MainStages(), CreateGroups(_skewb-r2, 2, 2024-08-25T11:00, 2024-08-25T11:30))
Map(MainStages(), CreateGroups(_222-r2, 2, 2024-08-25T11:30, 2024-08-25T12:00))
CreateMiscActivity("Lunch", "other-lunch", MAIN, 2024-08-25T12:00, 2024-08-25T13:00)
Map(MainStages(), CreateGroups(_666-r2, 1, 2024-08-25T13:00, 2024-08-25T13:20))
Map(MainStages(), CreateGroups(_clock-r2, 1, 2024-08-25T13:20, 2024-08-25T13:40))
Map(MainStages(), CreateGroups(_555-r2, 1, 2024-08-25T13:40, 2024-08-25T14:00))
Map(MainStages(), CreateGroups(_sq1-r2, 1, 2024-08-25T14:00, 2024-08-25T14:20))
Map(MainStages(), CreateGroups(_444-r3, 1, 2024-08-25T14:20, 2024-08-25T14:40))
Map(MainStages(), CreateGroups(_pyram-r3, 1, 2024-08-25T14:40, 2024-08-25T15:00))
Map(MainStages(), CreateGroups(_333oh-r2, 1, 2024-08-25T15:00, 2024-08-25T15:20))
Map(MainStages(), CreateGroups(_skewb-r3, 1, 2024-08-25T15:20, 2024-08-25T15:40))
Map(MainStages(), CreateGroups(_222-r3, 1, 2024-08-25T15:40, 2024-08-25T16:00))
Map(MainStages(), CreateGroups(_333bf-r2, 1, 2024-08-25T16:00, 2024-08-25T16:20))
Map(MainStages(), CreateGroups(_333-r4, 4, 2024-08-25T16:20, 2024-08-25T17:20))
CreateMiscActivity("Awards", "other-awards", RED, 2024-08-25T17:30, 2024-08-25T18:00)
