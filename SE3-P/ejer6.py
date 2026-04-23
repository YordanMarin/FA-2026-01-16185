s = int(input("Ingrese segundos: "))

h = s / 3600
m = (s % 3600) / 60
sr = s % 60

print(f"\n{h} : {m} : {sr}")