/**
	\brief Autorzy:Dominik Platos, Dorota Wrona. Projekt Kalkulator
	\details Program konsolowy realizujacy proste dzialania na liczbach. Umozliwia dodawanie, odejmowanie, mnozenie, dzielenie, potegowanie oraz pierwiastkowanie. Posiada takze przelicznik km na mile oraz mil na km
**/

#include<iostream>
#include<stdlib.h>
#include<math.h>

using namespace std;
/**
	\brief Klasa przelicznik
	\details Zawiera proste operacje polegajace na zamianie kilometrow na mile oraz mil na kilometry
**/
class przelicznik{
public:
	double m = 1.609344;
	double km_mi(double km){ return km / m; }
	double mi_km(double mi){ return mi*m; }
};
/**
\brief Klasa dzialania
\details Zawiera proste operacje polegajace na dodawaniu, odejmowaniu, mnozeniu, dzieleniu oraz pierwiastkowaniu. Obsluguje liczby zmiennoprzecinkowe.
**/
class dzialania{
public:
	double mnozenie(double a, double b){ return a*b; }/// Funkcja mnozenia
	double dzielenie(double a, double b){ return a / b; }/// funkcja dzielenia
	double dodawanie(double a, double b){ return a + b; }/// funkcja dodawania
	double odejmowanie(double a, double b){ return a - b; }/// funkcja odejmowania
	double pierwiastek(double a, double b){ return pow(a, 1. / b); }///funkcja pierwiastkowania
	double potega(double a, double b){ return pow(a, b); }/// potegowanie
};
int main(){
	/**
	\brief Funkcja Main
	\details Funkcja odpowiada za caly konsolowy interfejs z uzytkownikiem przy pomocy prostych petli umozliwiajacych wybor z menu za posrednictwem odpowiednich cyfr.
	**/
	int l1,l2,l3;///zmienne sterujace petlami
	double a, b;///zmienne odpowiedzialne za dzialania
	dzialania wynik;///obiekt klasy dzialania wyswietlajacy na ekran poprawny wynik
	przelicznik wynik1;///obiekt klasy przelicznik 
	/**
	\brief Petla sterujaca
	\details Umozliwia wybor z menu odpowiedniego dla uzytkownika dzialania
	**/
while (1){
		cout << "WPISZ LICZBE ABY WYBRAC NUMER Z MENU:\n"
			<< "1)Przelicznik\n"
			<< "2)Dzialania\n"
			<< "3)Wyjscie\n";
	
		cin >> l1;

	while ((l1 != 1 && l1 != 2 && l1!=3) || cin.good()==0){
			cout << "Podaj liczbe z menu\n";
			cin.clear();
			cin.sync();
			cin >> l1;
		}
		switch (l1){///Instrukcja warunkowa Odpowiedzialna za przeniesienie uzytkownika w odpowiednie miejsce programu w zaleznosci od tego jakie operacje chce wykonac
		case 1:
			cout << "Co chcesz przeliczyc ?\n"///Wybor przez uzytkownika rodzaju przelicznika
				<< "1)mile->kilometry\n"
				<< "2)kilometry->mile\n";
			while (1){
				cin >> l2;
				if (l2 == 1){
					cout << "Podaj liczbe mil\n";
					cin.clear();
					cin.sync();
					cin >> a;
					while (cin.good() == 0){
						cout << "Podales zly typ liczby, podaj liczbe z menu\n";
						cin.clear();
						cin.sync();
						cin >> a;
					}
					cout << a << " mil=" << wynik1.mi_km(a) << " kilometrow\n";
					break;
				}
				else if (l2 == 2){
					cout << "Podaj liczbe kilometrow\n";
					cin.clear();
					cin.sync();
					cin >> a;
					while (cin.good() == 0){
						cout << "Podales zly typ liczby, podaj liczbe z menu\n";
						cin.clear();
						cin.sync();
						cin >> a;
					}
					cout << a << " kilometrow=" << wynik1.km_mi(a) << " mil\n";
					break;
				}
				else cout << "Musisz podac liczbe z menu\n";
			}
			break;
		case 2:///Odniesienie do szeregu operacji na liczbach zawartych w klasie dzialania
			cout << "Wybierz rodzaj dzialania:\n"
				<< "Pamietaj, ze liczby zmiennoprzecinkowe oddzielamy kropka\n"
				<< "1)dodawanie\n"
				<< "2)odejmowanie\n"
				<< "3)mnozenie\n"
				<< "4)dzielenie\n"
				<< "5)pierwiastek\n"
				<< "6)potega\n";
			cin >> l3;
			if (l3 == 1){
				cout << "Podaj liczby ktore chcesz dodac, po danej liczbie nacisnij enter\n";
				cin >> a >> b;
				while (cin.good() == 0){
					cout << "Podales zly typ liczby, podaj sprobuj ponownie\n";
					cin.clear();
					cin.sync();
					cin >> a >> b;
				}
				//wynik.dodawanie(a, b);
				cout << a << "+" << b << "=" << wynik.dodawanie(a, b)<<endl;
				break;
			}
			else if (l3 == 2){
				cout << "Podaj liczby ktore chcesz odjac, po danej liczbie nacisnij enter\n";
				cin >> a >> b;
				while (cin.good() == 0){
					cout << "Podales zly typ liczby, podaj sprobuj ponownie\n";
					cin.clear();
					cin.sync();
					cin >> a >> b;
				}
				//wynik = odejmowanie(a, b);
				cout << a << "-" << b << "=" << wynik.odejmowanie(a, b) << endl;
				break;
			}
			else if (l3 == 3){
				cout << "Podaj liczby ktore chcesz pomnozyc, po danej liczbie nacisnij enter\n";
				cin >> a >> b;
				while (cin.good() == 0){
					cout << "Podales zly typ liczby, podaj sprobuj ponownie\n";
					cin.clear();
					cin.sync();
					cin >> a >> b;
				}
				//wynik = mnozenie(a, b);
				cout << a << "*" << b << "=" << wynik.mnozenie(a, b) << endl;
				break;
			}
			else if (l3 == 4){
				cout << "Podaj liczby ktore chcesz podzielic, po danej liczbie nacisnij enter\n";
				cin >> a >> b;
				while (cin.good() == 0){
					cout << "Podales zly typ liczby, podaj sprobuj ponownie\n";
					cin.clear();
					cin.sync();
					cin >> a >> b;
				}
				while (b == 0){
					cout << "Pamietaj, ze mianownik musi byc rozny od zera!!\n"
						<< "Jaki wiec chcesz mianownik?\n";
					cin.clear();
					cin.sync();
					cin >> b;
				}
				//wynik = dzielenie(a, b);
				cout << a << "/" << b << "=" << wynik.dzielenie(a, b) << endl;
				break;
			}
			else if (l3 == 5){
				cout << "Podaj stopien pierwiastka\n";
				cin >>b;
				while (cin.good() == 0){
					cout << "Podales zly typ liczby, podaj sprobuj ponownie\n";
					cin.clear();
					cin.sync();
					cin >> b;
				}
				cout << "Podaj liczbe pod pierwiastkiem\n";
				if ((int)b % 2 != 0){
					cin >> a;
					while (cin.good() == 0){
						cout << "Podales zly typ liczby, podaj sprobuj ponownie\n";
						cin.clear();
						cin.sync();
						cin >> a;
					}
					//wynik = pierwiastek(a, b);
					cout << "Pierwiastek  " << b << "stopnia z liczby" << a << "=" << wynik.pierwiastek(a, b) << endl;
					break;
				}
				else{
					cout << "Liczba pod pierwiastkiem musi byc wieksza lub rowna 0\n";
					cin >> a;
					while (cin.good() == 0 || a<0){
						cout << "Podales zly typ liczby, podaj sprobuj ponownie\n";
						cin.clear();
						cin.sync();
						cin >> a;
					}
					//wynik = pierwiastek(a, b);
					cout << "Pierwiastek  " << b << "stopnia z liczby" << a << "=" << wynik.pierwiastek(a, b) << endl;
					break;
				}
			}
			else if (l3 == 6){
				cout << "Podaj liczbe ktora chcesz podniesc do potegi\n";
				cin >> a;
				while (cin.good() == 0){
					cout << "Podales zly typ liczby, podaj sprobuj ponownie\n";
					cin.clear();
					cin.sync();
					cin >> a;
				}
				cout << "Podaj potege\n";
				cin >> b;
				while (cin.good() == 0){
					cout << "Podales zly typ liczby, podaj sprobuj ponownie\n";
					cin.clear();
					cin.sync();
					cin >>b;
				}
				//wynik = potega(a, b);
				cout << "a^b=" <<wynik.potega(a, b) << endl;
				break;
			}
			else cout << "Musisz podac liczbe z menu\n";
			break;
		}
		if (l1 == 3) break;
	}
	///koniec dzialania programu, wszystkie petle zakonczyly sie prawidlowo.
system("Pause");
		return 0;
}