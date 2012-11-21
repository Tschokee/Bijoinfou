// Fusion.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


//Global variables
//Hali
FILE *genes,*fusion; 
//Beni

//Tschokee

//Juri


char *concater(int i){
	char* buffer = (char*)malloc(1024);
	buffer="ATGTCGT";
	return buffer;
}
char *otherstring(int i){
	char* buffer = (char*)malloc(1024);
	 buffer="ATGTCGT";
	return buffer;
}


bool algorithm(char *concated, char *string){
	return true;
}

int _tmain(int argc, _TCHAR* argv[])
{
	//genes = fopen ("genes.txt" , "r");
	//fusion = fopen ("fusion.txt" , "r");
	printf("%d   %s   %s \n",algorithm(concater(6),otherstring(6*2)),concater(6),otherstring(6*2));



	return 0;
}

