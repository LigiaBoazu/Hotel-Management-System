# Hotel-Management-System

Aplicația este dezvoltată în C# (.NET Framework 4.8) și utilizează SQLite pentru baza de date. Sistemul oferă o serie de funcționalități pentru a sprijini personalul hotelier în gestionarea rezervărilor și a sarcinilor administrative prin controlul accesului bazat pe roluri (administrator, recepționer sau client).

## Funcționalități

1. Funcțiile recepționerilor
- Rezervări pentru clienți
- Adăugare de camere în sistem
- Ștergerea camerelor din sistem
- Vizualizarea rezervărilor

2. Funcțiile administratorului de sistem (manager)
- Rezervări pentru clienți
- Adăugare de camere în sistem
- Ștergerea camerelor din sistem
- Vizualizarea rezervărilor
- Crearea de conturi pentru recepționeri sau clienți

3. Funcțiile clientului
- Rezervări (în cazul în care au cont)


## Interfața cu utilizatorul

### Pagina de Autentificare
![Log In Page](images/LogIn.png)

### Pagina Administratorului
Administratorul este utilizatorul cu cele mai multe drepturi de acces. Pagina sa conține 3 secțiuni: Rezervare, Adaugă Cameră și Adaugă user.
![Pagina Administratorului](images/AdminPage.png)

### Caută o rezervare
O rezervare se poate căuta după nume, prenume sau numele și prenumele asociat rezervării.
![Cauta Rezervare](images/CautaRezervare.png)

### Șterge o rezervare
Pentru a șterge o rezervare se selectează numărul rezervării.
![Sterge Rezervare](images/StergeRezervare.png)

### Șterge o cameră
Pentru a șterge o cameră se selectează numărul camerei.
![Sterge Camera](images/StergeCamera.png)

### Pagina Recepționerului
Pagina recepționerului conține 2 secțiuni: Rezervare și Adaugă Cameră. Acesta nu poate introduce utilizatori în sistem.
![Pagina Receptionerului](images/RecepPage.png)

### Pagina Clientului
Pagina clientului conține o singură secțiune: Rezervare.
![Pagina Clientului](images/ClientPage.png)

## Meniul de Help
Aplicația conține și meniuri de help create cu HelpNDoc 9.
![Help](images/Help.png)
