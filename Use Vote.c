#include<stdio.h>
int main(){
	int age;
	printf("You enter age: \n");
	scanf("%d",&age);
	if(age >= 18){
		printf("You can use vote\n");
	}
	else{
		printf("You can't use vote\n");
	}
	return 0;
}
