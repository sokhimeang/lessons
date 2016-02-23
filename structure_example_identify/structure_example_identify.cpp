#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<iostream>
using namespace std;
struct identify{
	int id;
	char name[20];
};
main(){
	identify idtf[100];
	int number;
	cout << "enter number: ";
	cin >> number;
	for(int i=1; i<=number; i++){
		cout << "enter id of "<< i<< ": ";
		cin >> idtf[i].id;
		cout << "enter name of "<< i<< ": ";
		cin >> idtf[i].name;		
	}
	for(int i=1; i<=number; i++){
		cout << i<< " ).\tid: "<< idtf[i].id<< "\t\tname: "<< idtf[i].name<< "\n";
	}
	getch();
}
