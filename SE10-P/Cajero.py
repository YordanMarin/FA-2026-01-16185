class Cajero:
    saldo = 1000;

    def Consultar(self)->float:
        return self.saldo

    def Depositar(self, monto)->None:   
        self.saldo += monto
        print("\nDeposito exitoso")
                    

            
