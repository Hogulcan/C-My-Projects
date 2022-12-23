#include<stdio.h>

int main(){
	int a,b,unknown;
	printf("Enter A: ");
	scanf("%d", &a);
	printf("Enter B: ");
	scanf("%d", &b);
	int calculate = 180 - (a + b);
	printf("Unknown: %d", calculate);
	return 0;
}
