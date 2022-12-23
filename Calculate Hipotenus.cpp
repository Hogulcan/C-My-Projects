#include<stdio.h>

int main(){
	int a,b,a_square,b_square,hipotenus;
	printf("Enter A: \n");
	scanf("%d", &a);
	a_square = a * a;
	printf("Enter B: \n");
	scanf("%d", &b);
	b_square = b * b;
	hipotenus = a_square + b_square;
	printf("Hipotenus: %d", hipotenus);
	return 0;
}
