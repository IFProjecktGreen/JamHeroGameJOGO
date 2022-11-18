INCLUDE global.ink

#???

-> main

=== main ===
Vejamos quem está aqui de novo.
Quer tentar novamente?
    *[Quero, porfavor]
        Tudo bem, mas não esquece... Você só tem mais uma oportinidade
        ~DemonioContrato = "true"
            ->DONE
    *[Não, acho melhor desistir]
        Você tem certeza mesmo? 
        Foi tão quase...
            **[Não quero mais]
                Vai desistir só porque matou a sua família duas vezes
                HAHAHAHAHAHAHA
                Vai la cagão
                ...Tem certeza ne?
                    ***[Eu quero mais uma chance!!]
                        Tudo bem, mas não esquece... Você só tem mais uma oportinidade
                        ~DemonioContrato = "true"
                            ->DONE
                    ***[Tenho...]
                        ...Cagão
                        ~Final1 = "true"
                            ->DONE
            **[Na verdade eu preciso de mais uma chance]
            Tudo bem, mas não esquece... Você só tem mais uma oportinidade
            ~DemonioContrato = "true"
                ->DONE
            
->END