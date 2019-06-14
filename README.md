# CRUDPatrimonio

**Mostrar para o Usuario**
----
  Retornar json data para um Patrimonio/.

* **URL**

  /Patrimonio/:id

* **Method:**

  `GET`
  
*  **URL Params**

   **Required:**
 
   `id=[integer]`

* **Ligar com Banco de Dados SQL Server Express**

Editar arquivo "appsettings.json"

 "ConnectionStrings": {
    "DefaultConnection": "Data Source=SEU_SERVIDOR_SQLSERVER_LOCAL;Initial Catalog=MeuGrud;Integrated Security=true"

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ id : 12, name : "Patrimonio" }`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `{ error : "Patrimonio Nao existe" }`

  OR

  * **Code:** 401 UNAUTHORIZED <br />
    **Content:** `{ error : "You are unauthorized to make this request." }`

* **Sample Call:**

  ```javascript
    $.ajax({
      url: "/users/1",
      dataType: "json",
      type : "GET",
      success : function(r) {
        console.log(r);
      }
    });
  ```