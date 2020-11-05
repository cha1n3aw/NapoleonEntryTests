#include <iostream>
using namespace std;

bool palindrome(unsigned long long num);
int power(int base, int exp);
int main()
{
	do
	{
		cout << "World up!\nCome on dear, tell me your number...\x0A";
		unsigned long long num = 0;
		cin >> num;
		if (palindrome(num)) cout << "\nThat's success!\x0A\x0A";
		else cout << "\nFeels bad, but that's definetly not a palindrome =(\x0A\x0A";
	} 
	while (1);
	return 0;
}
bool palindrome(unsigned long long num)
{
	int cnt = 0;
	unsigned long long digit = num;
	while (digit > 0) { digit /= 10; cnt++; }
	int temp_cnt = cnt;
	for (int i = 0; i < temp_cnt / 2; i++)
	{
		if (num < 10) return true;
		if (num % 10 == num / power(10, cnt - 1))
		{
			num = num % power(10, cnt - 1);
			num /= 10;
			cnt -= 2;
		}
		else return false;
	}
	return true;
}
int power(int base, int exp)
{
	int newbase = base;
	for (int i = 0; i < exp-1; i++) newbase *= base;
	return newbase;
}