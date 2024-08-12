#include "_constants.cs"

Define("StaffTeams", [
    Tuple(2005REYN01, FLOATING),
    Tuple(2018GIBS04, FLOATING),
    Tuple(2022AMAR09, FLOATING),
    Tuple(2017DURE01, GREEN),
    Tuple(2012SZEL01, GREEN),
    Tuple(2018PIKE01, GREEN),
    Tuple(2019VILL03, GREEN),
    Tuple(2017MARR02, BLUE),
    Tuple(2014MAIL01, BLUE),
    Tuple(2022CHES04, BLUE),
    Tuple(2021RAME01, BLUE),
    Tuple(2021GUDB01, BLUE),
    Tuple(2015RUSS03, RED),
    Tuple(2013MART03, RED),
    Tuple(2015COHE02, RED),
    Tuple(2014PHIL02, RED),
    Tuple(2022ZHEN06, RED),
    Tuple(2017CIRA01, DATA),
    Tuple(2022CHES03, DATA),
    Tuple(2023GRAY10, DATA)
])

Define("StaffTeam", Switch({1, Person}, StaffTeams(), ""))

Define("IsStaff", Not((StaffTeam({1, Person}) == "")))
