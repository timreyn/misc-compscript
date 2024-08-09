# Stages
#define RED "Red Stage"
#define BLUE "Blue Stage"
#define GREEN "Green Stage"

Define("Stages", [RED, BLUE, GREEN])
Define("MainStages", [RED, BLUE])

#define DATA "Data"
#define FLOATING "Floating"
#define DELEGATE "delegate"
#define TRAINEE_DELEGATE "trainee-delegate"

Define("IsDelegate", Or(HasRole({1, Person}, DELEGATE), HasRole({1, Person}, TRAINEE_DELEGATE)))
