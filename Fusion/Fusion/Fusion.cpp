// Fusion.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


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


	printf("%d/n",algorithm(concater(6),otherstring(6*2)));



	return 0;
}

