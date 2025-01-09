#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
	char name[50];

	printf("Enter you name: ");
	scanf("%49s", name);

	printf("Hello, %s!\n", name);

	printf("enter anything to continue");
	scanf("%s", name);

	return 0;
}