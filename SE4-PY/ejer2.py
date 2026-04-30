an = int(input("Año: "))

if((an % 4 == 0 and an%100 != 0) or an%400 ==0):
    print("\nBisiesto")
else: 
    print("\nNo bisisesto")

if (an%2==0): print("Par")
else: print("impar")