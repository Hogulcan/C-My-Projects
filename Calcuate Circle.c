#include<stdio.h>
#define PI 3
int main(){
	int r;
	printf("You enter r: ");
	scanf("%d",&r);
	printf("Circle Area: %d",PI * r * r);
	printf("Circle Enviroment: %d",2 * PI * r);
	return 0;
}
