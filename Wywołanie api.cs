/*

Api dla programu do raportowania dnii pracujacych dla ekipy wyjazdowej

wywołania 

GET                  {login}/api/[controler]    
POST                 {login}/api/[controler]
UPDATE/DELETE/PATCH  {login}/api/[controler]/{id}

Controlery: 
Stawki              - obsługa ustawiania stawek [model Stawki - StawkiDto]   
                    np. user1/api/Stawki
                    np. user1/api/Stawki/1
                
Rozliczanie          - obsługa ustawiania Rolziczenia dnii [model RozliczenieDnia -RozliczenieDniaDto] 
                    np. user1/api/Rozliczanie
                    np. user1/api/Rozliczanie/1

Logowanie- repozytorium wewetrzne nie wystawione jako zewnetrzne API, na rzzie zmianiac bezposrednio w Bazie SQL
 
 


 */