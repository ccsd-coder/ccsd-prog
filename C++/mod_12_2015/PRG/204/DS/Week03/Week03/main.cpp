#include <cstdio>
#include <cstring>



/*
char* ip_address = "127.0.0.1";
write a function that:

- finds the length of the string

- record the position of the dots ( "." ) inside the string
*/
////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////
int Assigment01( char* string )
{
    int size = strlen( string );
    printf( "The size of the variable string is : %i\n", size );
    for( int i = size - 1; i >= 0; i-- )
    {
        printf( "%i - %c\n", i, string[ i ] );
    }
    return size;
}

/*
#6).Write a program for a furniture company. Ask the user to choose P for pine, O for oak, or
Mfor mahogany. Show the price of a table manufactured with the chosen wood. Pine
tables cost $100, oak tables cost $225, and mahogany tables cost $310. Save the program
as Furniture.cpp.

#8) .Write a program that generates a random number from 0 through 9 and allows the
user to guess the number. Display one of three messages depending on whether the
guesser was exactly correct, within two of the random number, or off by more than two.
(Appendix E contains information on how to generate a random number.) Save the
program as GuessingGame.cpp.
*/
void Assignment02()
{
    printf( "Please choose P for pine, O for oak, M for Mahogany");
    char c = 0;
    scanf( "%c", &c );
    switch( c )
    {

        case 'P' :
            {
                printf( "For Pine, price is $100\n");
            } break;
        case 'O' :
            {
                printf( "For Oak, price is $225\n");
            } break;
        case 'M' :
            {
                printf( "For Mahogany, price is $310\n");
            } break;
        default:
            {
                printf( "Input not recognised - Aborting\n");
                return;
            } break;
    }
    return;
}

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////
int main()
{
    char* string = "Something else";
    char* string2 = "Yet another one";
    char* string3 = "I don't know";

    int size = Assigment01( string );
    //int size2 = Assigment01( string2 );
    //int size3 = Assigment01( string3 );

    printf( "In main, now we have recorded the value of the 1st string as being %i\n", size );
    return 0;
}
