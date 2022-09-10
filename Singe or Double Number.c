#include<stdio.h>
int main(){
	int number;
	printf("Enter Number: \n");
	scanf("%d",&number);
	if(number % 2 == 0){
		printf("This is a double number\n");
	}
	else{
		printf("This is a single number");
	}
	return 0;
}
