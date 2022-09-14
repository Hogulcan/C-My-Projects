#include<stdio.h>
int main(){
	int correct_answer,wrong_answer,calculate;
	printf("You enter correct answer: ");
	scanf("%d",&correct_answer);
	printf("You enter wrong answer: ");
	scanf("%d",&wrong_answer);
	calculate = correct_answer - (wrong_answer / 4);
	printf("Total Point of University Exam: %d",calculate);
	return 0;
}
