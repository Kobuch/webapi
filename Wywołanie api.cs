/*

Api dla programu do raportowania dnii pracujacych dla ekipy wyjazdowej

wywołania 

Pobranie token  
POST                 /name/authenticate   body:  "Username": "...",  "Password": "..." W odpowiedzi otrzymasz token 


Autoryzacja Bearer Token

GET                  /api/[controler]    
POST                 /api/[controler]
UPDATE/DELETE/PATCH  /api/[controler]/{id}

Controlery: 
Stawki              - obsługa ustawiania stawek [model Stawki - StawkiDto]   
                    np. api/Stawki
                    np. api/Stawki/1
                
Rozliczanie          - obsługa ustawiania Rolziczenia dnii [model RozliczenieDnia -RozliczenieDniaDto] 
                    np. api/Rozliczanie
                    np. uapi/Rozliczanie/1

Logowanie- repozytorium wewetrzne nie wystawione jako zewnetrzne API, na rzzie zmianiac bezposrednio w Bazie SQL
 
 


 */