num = input(int("Ingrese un número: "))
pares = 0

for i in range(1,num+1):

   if (i%2==0):
      pares += i;
      #pares = pares + i;

print("\n\nSuma de pares: ",pares);