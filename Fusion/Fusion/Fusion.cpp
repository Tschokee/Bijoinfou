// Fusion.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

//Global variables
//Hali
FILE *genes,*fusion;
//Beni

//Tschokee
struct idAndGenes{
    char id[11];
    char* gene;
};
idAndGenes g;
idAndGenes dataBase[100000];
//Juri

void load(){ // még nem megy jól, van valami gond a fájlformátummal
    int i=0;
    while(1){
        if( fgets(dataBase[i].id, 10 , fusion)==NULL)
            break;
        //printf("%s --- " , dataBase[i].id);
        free(dataBase[i].gene);
        dataBase[i].gene = (char*)malloc(10000*sizeof(char));
        fgetc(fusion);
        fgets(dataBase[i].gene, 10000 , fusion);
        //printf("%s\n" , dataBase[i].gene);
        i++;
    }
    return;
}

char *concater(int i){
	char* buffer = (char*)malloc(i*sizeof(char));
	buffer="ATGTCGT";
	return buffer;
}
void otherstring(int i){
    char c;
	//char* buffer = (char*)malloc(i*sizeof(char));
	fgets(g.id, 10 , fusion);
	free(g.gene);
	g.gene = (char*)malloc(1000*sizeof(char));
	fgetc(fusion);
    fgets(g.gene, 1000 , fusion);
	/*for(int j = 0 ; ; j++)//realloc-al nem akar mûködni valamiért olyat foglal le amit nem kéne
	{
	    c = fgetc(fusion);
	    if( c == '\n' || c == '*')
        {
            printf("megall\n");
            break;
        }
        realloc(g.gene, sizeof(char));
        g.gene[j] = c;
        //printf("%c",g.gene[j]);
	}
	//while( fgets(buffer,i,fusion) != NULL);
	//buffer="ATGTCGT";
	//return g.gene;
	//printf("%s\n",g.gene);*/
	return;
}


bool algorithm(char *concated, char *string){
    //amíg nincsenek struktúrák nem tudom elkezdeni
    return true;
}

int _tmain(int argc, _TCHAR* argv[])
{
	//genes = fopen ("genes.txt" , "r");
	fusion = fopen ("Acralc1.fasta" , "r");
	load();
	otherstring(6*2);
    fclose(fusion);
	return EXIT_SUCCESS;
}

