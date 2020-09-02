#include <iostream>

using namespace std;

double a, b, c;

int main() 
{
	cout << "u have equation: ax^2 + bx + c = 0 need to find x." << endl;

	cout << "Input a " << endl;
	cin >> a;

	cout << "Input b " << endl;
	cin >> b;

	cout << "\nInput c " << endl;
	cin >> c;

	double D;

	
	if (a == 0)
	{
		if (b == 0)
		{
			if (c == 0)
			{
				cout << "x is any real number " << endl;
				return 0;
			}
			else
			{
				cout << " b can`t be zero.";
				return 0;
			}
		}
		cout << "x = " << -c / b << endl;
		return 0;
	}

	D = b * b - 4 * a * c;
	if (D > 0)
	{
		cout << "x1 = " << ((-b + sqrt(D)) / (2 * a)) << "\t x2 = " << (-b - sqrt(D)) / (2 * a) << endl;
		return 0;
	}
	else if (D == 0)
	{
		cout << "x1-2 = " << (-b + sqrt(D)) / (2 * a) << endl;
		return 0;
	}
	else
	{
		cout << "x not exist" << endl;
		return 0;
	}
	
	system("pause");
	return 0;
}