/*

Api dla programu do raportowania dnii pracujacych dla ekipy wyjazdowej



Autoryzacja Bearer Token
Pobranie token  
POST                 /name/authenticate   body:  "Username": "...",  "Password": "..." W odpowiedzi otrzymasz token 




wywołania 

GET                  /api/[controler]    
POST                 /api/[controler]
UPDATE/DELETE/PATCH  /api/[controler]/{id}

Controlery: 
Stawki              - obsługa ustawiania stawek [model Stawki - StawkiDto]   
                    np. api/Stawki
                    np. api/Stawki/1
                
Rozliczanie          - obsługa ustawiania Rolziczenia dnii [model RozliczenieDnia -RozliczenieDniaDto] 
                    np. login/api/Rozliczanie
                    np. login/api/Rozliczanie/1

Uwaga
Logowanie- repozytorium wewetrzne z danymi do logowania nie wystawione jako zewnetrzne API, na razie zmianiac bezposrednio w Bazie SQL
 
 


 */