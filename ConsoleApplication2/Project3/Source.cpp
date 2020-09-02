#include <iostream>

using namespace std;

int main()
{
	bool shtora, room, time, lamp;
		
	cout << "day or night? (night = 0, day = 1) ";
	cin >> time;

	cout << "lamp on or off? (off = 0 on = 1)";
	cin >> lamp;

	cout << "shtora on or off? (off = 0 on = 1)";
	cin >> shtora;

	if ((time == 1 and shtora == 1) or lamp == 1)
	{
		cout << "the room is light";
	}
	else
		cout << "the room is dark";
	return 0;
}