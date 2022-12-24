#include<stdio.h>

int main(){
	int a,b,area,enviroment;
	printf("Enter A: \n");
	scanf("%d", &a);
	printf("Enter B: \n");
	scanf("%d", &b);
	area = a * b;
	printf("Area: %d\n", area);
	enviroment = (a + b) * 2;
	printf("Enviroment: %d", enviroment);
	return 0;
}
