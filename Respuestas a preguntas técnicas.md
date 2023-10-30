Pregunta 1:
Dedicé aproximadamente 3 horas a la prueba de codificación. Si tuviera más tiempo, agregaría las siguientes mejoras a mi solución:

Implementaría una interfaz de usuario más amigable para la aplicación web, mejorando el diseño y la experiencia del usuario.
Agregaría manejo de errores más robusto y mensajes de error informativos para manejar situaciones excepcionales de manera más elegante.
Implementaría autenticación y autorización adecuadas, en lugar de almacenar las credenciales en el código.

Pregunta 2:
La característica más útil agregada a la última versión de C# (en la fecha de mi conocimiento en septiembre de 2021) fue la capacidad de patrones de coincidencia. 
Esto simplifica y mejora la legibilidad del código al permitir patrones de coincidencia en declaraciones switch, if, while, entre otros. 
A continuación, se muestra un ejemplo simple de cómo lo he utilizado:

int dayOfWeek = 3;
string dayName = dayOfWeek switch
{
    1 => "Lunes",
    2 => "Martes",
    3 => "Miércoles",
    4 => "Jueves",
    5 => "Viernes",
    6 => "Sábado",
    7 => "Domingo",
    _ => "Día no válido"
};

Pregunta 3:
Para localizar un problema de rendimiento en producción, utilizaría diversas estrategias:

Sí, he tenido que localizar problemas de rendimiento en producción tanto en mis proyectos de estudio como en el trabajo diario. 
Para poder mejorar el rendimiento debugeo el procedimiento para encontrar maneras de refactorizacion mas efectivas y rapidas.
Considero que es una parte importante del mantenimiento y la mejora continua de las aplicaciones.

Pregunta 4:
Antes que nada me gustaria recalcar que me ha parecido una API facil de implementar en codigo, mis propuestas serian las siguientes:

Proporcionar una documentación más detallada y completa para los desarrolladores, incluyendo ejemplos de solicitud y respuesta.
Implementar una política de control de acceso para limitar el acceso a ciertas funciones o recursos.
Ofrecer opciones de paginación y filtrado de resultados para facilitar la recuperación de datos específicos.

Estas mejoras ayudarían a que la API sea más segura, fácil de usar y eficiente para los desarrolladores que la utilizan.