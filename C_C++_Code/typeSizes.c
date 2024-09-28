// Harris Ransom
// C Type Sizes
// 08/27/2024

// Includes
#include <stdio.h>

// MAIN
int main(int argc, char **argv) {
    // Ints
    short int       aShortInt;
    int             aInt;
    long int        aLongInt;
    long long int   aLongLongInt;

    // Chars
    char            aChar;
    unsigned char   aUnsignedChar;

    // Floats
    float   aFloat;
    double  aDouble;

    // Pointers
    int *   aIntP;
    void *  aVoidP;

    // Output sizes
    printf("Size of (short)     = %ld bytes\n", sizeof(short));
    printf("Size of (int)       = %ld bytes\n", sizeof(int));
    printf("Size of (long)      = %ld bytes\n", sizeof(long));
    printf("Size of (long long) = %ld bytes\n", sizeof(long long));
    
    printf("Size of (char)      = %ld bytes\n", sizeof(char));
    printf("Size of (uchar)     = %ld bytes\n", sizeof(unsigned char));

    printf("Size of (float)     = %ld bytes\n", sizeof(float));
    printf("Size of (double)    = %ld bytes\n", sizeof(double));

    printf("Size of (int *)     = %ld bytes\n", sizeof(aIntP));
    printf("Size of (void *)    = %ld bytes\n", sizeof(aVoidP));   
}