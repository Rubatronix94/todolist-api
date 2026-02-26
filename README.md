#<img width="1364" height="768" alt="Captura de pantalla (173)" src="https://github.com/user-attachments/assets/eae36533-667d-4838-acc8-d3b57bff06e5" />
<img width="1364" height="768" alt="Captura de pantalla (172)" src="https://github.com/user-attachments/assets/d2cc65b3-0d57-4f51-978b-8ae30707469e" />
 📝 TodoList API

API REST desarrollada con **ASP.NET Core** y **Entity Framework Core** para gestionar tareas. Incluye una interfaz web para interactuar con el CRUD sin necesidad de Swagger.

---

## 🖥️ Vista previa

> Interfaz web incluida en `wwwroot/index.html`

Funcionalidades visibles:
- Lista de tareas con estado (pendiente / completada)
- Formulario para crear tareas
- Edición y eliminación desde la interfaz

---

## 🛠️ Tecnologías usadas

- ASP.NET Core 8
- Entity Framework Core 8
- SQL Server
- HTML + CSS + JavaScript (vanilla)

---

## 📁 Estructura del proyecto

```
todolist-api/
├── Controllers/
│   └── TareasController.cs   # Endpoints de la API
├── Modelos/
│   ├── Tareas.cs             # Modelo de datos
│   └── TareasContext.cs      # Contexto de base de datos
├── Migrations/               # Migraciones de EF Core
├── wwwroot/
│   └── index.html            # Interfaz web
├── Program.cs
└── appsettings.json          # ⚠️ No incluido (ver configuración)
```

---

## ⚙️ Configuración

El archivo `appsettings.json` no está incluido por seguridad. Créalo en la raíz del proyecto con este contenido:

```json
{
  "ConnectionStrings": {
    "CadenaSQL": "Server=TU_SERVIDOR;Database=TU_BASE_DE_DATOS;Trusted_Connection=True;TrustServerCertificate=True"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

Reemplaza `TU_SERVIDOR` y `TU_BASE_DE_DATOS` con tus datos reales.

---

## 🚀 Cómo ejecutar el proyecto

**Requisitos previos:**
- .NET 8 SDK
- SQL Server (local o remoto)
- Visual Studio 2022 o VS Code

**Pasos:**

1. Clona el repositorio
   ```bash
   git clone https://github.com/TU_USUARIO/todolist-api.git
   ```

2. Crea el archivo `appsettings.json` (ver sección anterior)

3. Aplica las migraciones para crear la base de datos
   ```bash
   dotnet ef database update
   ```

4. Ejecuta el proyecto
   ```bash
   dotnet run
   ```

5. Abre la interfaz web en el navegador
   ```
   https://localhost:7080/index.html
   ```

---

## 📡 Endpoints de la API

| Método | Ruta | Descripción |
|--------|------|-------------|
| `GET` | `/api/Tareas/lista` | Obtener todas las tareas |
| `GET` | `/api/Tareas/ver?id={id}` | Obtener una tarea por ID |
| `POST` | `/api/Tareas/crear` | Crear una nueva tarea |
| `PUT` | `/api/Tareas/editar?id={id}` | Editar una tarea existente |
| `DELETE` | `/api/Tareas/eliminar?id={id}` | Eliminar una tarea |

### Ejemplo de JSON para crear/editar una tarea

```json
{
  "titulo": "Hacer la compra",
  "tarea": "Leche, huevos, pan",
  "completado": false
}
```

---

## 👤 Autor

** rubatronix **  
[GitHub](https://github.com/Rubatronix94) · [LinkedIn](https://linkedin.com/in/ruba-tron-39a706294)
