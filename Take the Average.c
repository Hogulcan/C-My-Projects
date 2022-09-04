#include<stdio.h>
int main(){
	int x,y,z,calculate;
	printf("Enter X: ");
	scanf("%d",&x);
	printf("Enter Y: ");
	scanf("%d",&y);
	printf("Enter Z: ");
	scanf("%d",&z);
	calculate = (x+y+z) / 3;
	printf("Average: %d",calculate);
	return 0;
}
