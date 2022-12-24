#include<stdio.h>

int main(){
	int a,b,c;
	printf("Enter A: \n");
	scanf("%d", &a);
	printf("Enter B: \n");
	scanf("%d", &b);
	printf("Enter C: \n");
	scanf("%d", &c);
	int process = a + b + c;
	printf("Total: %d", process);
	return 0;
}
