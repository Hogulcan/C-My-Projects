#include<stdio.h>

int main(){
	int n,process;
	printf("Enter n: \n");
	scanf("%d", &n);
	process = ( (n - 3) * n) / 2;
	printf("You can to draw %d diagonal", process);
	return 0;
}
