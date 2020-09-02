#include <iostream>

using namespace std;

double b, c;

int main() {
	cout << "u have equation: bx + c = 0 need to find x." << endl;

	cout << "Input b " << endl;
	cin >> b;
	
	cout << "\nInput c " << endl;
	cin >> c;
	
	if (b == 0) {
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

	system("pause");
	return 0;
}