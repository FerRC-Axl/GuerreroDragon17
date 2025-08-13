# 🛡️ Hoja de Observación - Prueba cruzada de guerreros

**Nombre del equipo que prueba:** _Equipo dinamita____  
**Nombre del equipo dueño del código:** _Guillermo Fernando Rosas Casco___  
**Fecha:** __12/08/25__

---

## 1. Datos generales del guerrero evaluado

| Atributo        | Valor |
|-----------------|-------|
| Nombre del guerrero |Guerrero  17|
| Vida base       | 100 |
| Ataque base     | 10  |
| Defensa base    | 10  |
| Velocidad       | --- |

---

## 2. Pruebas de combate con enemigos personalizados

Prueba el guerrero con enemigos que tengan distintos niveles de fuerza, vida y velocidad.

| Enemigo # | Vida | Ataque | Velocidad | ¿Ganó el guerrero? | Observaciones |
|-----------|------|--------|-----------|---------------------|----------------|
| 1         | 100  |   5    |    ---    |    si               | Usa numeros aletorios para determinar quien gana. |
| 2         |      |   4    |           |    si               | Valores inferiores a los del guerrero.            |
| 3         |      |   11   |           |    si               | El guerrero seguira ganando hasta ue no tenga vida.|
| 4         |      |   ---  |           |    no               | El guerrero perdio ya que se uedo sin energia.      |
| 5         |      |   12   |           |    no               | Solo se entreno una ve y no fue lo suficiente par ganar la batalla.|

---

## 3. Evaluación del sistema de entrenamiento

### A. Entrenar fuerza

- ¿Aumenta la fuerza después de entrenar? si
- ¿Consume energía de forma proporcional a las horas? sin determinar
- ¿El entrenamiento respeta el límite de 6 horas? no esta determinado 
- Observaciones:  
  Cuando duerme el guerrero recupera 35 de experiencia, es decir, que debe de entrenar lo suficiente para alcanzar la suficiente vida par las batallas no basta con solo una.

### B. Entrenar resistencia

- ¿Aumenta la resistencia?  SI
- ¿Afecta otras estadísticas? (por ejemplo, menos energía) SI, la energia 
- ¿Tiene sentido el impacto por hora entrenada? SI  
- Observaciones:  
  Al entrenar la resistencia esta aumenta 5 de experiencia y 9 de energia. Cuando se efrenta al enemigo al meno una vez gana 15 de experiencia.  

### C. Dormir / Descansar

- ¿Recupera energía al descansar? ✅ 
- ¿Se evita sobrecargar la energía (por ejemplo, pasar de 100)?  ❌, esto no pasa ya que no tiene establecido si la vida tiene un limite.  
- Observaciones:  
  A pesar que no haya pelea, pero se duerme el guerrero podemos llegar a un numero grande de veces para dormirlo y no marca si la energia ha llegado a su limite establecido. 

---

## 4. Progresión y balance

- ¿El personaje sube de nivel correctamente con la experiencia acumulada? ✅ 
- ¿Se siente balanceado el avance del personaje? ✅ 
- ¿Hay consecuencias claras si no tiene energía (por ejemplo, no puede entrenar)? ✅  
- Observaciones:  
  Con cada batalla ganada, el guerrero gana experiencia y con ello sube de nivel poco a poco, pero como lo habia mencionado antes el que entre una vez no es suficiente para seguir con la batalla y como consecuencia pierde 20 de vida. 
---

## 5. Revisión de requisitos técnicos del código

| Requisito                                                        | Cumple ✅ / ❌ | Comentarios |
|------------------------------------------------------------------|---------------|-------------|
| Menú interactivo con `switch` que se repite                     |    si          | No tiene un limite de usos.    |
| Al menos una función por actividad (Ej: `EntrenarFuerza()`)     |    si         | Cumple con esta funcion y llega al siguiente nivel. |
| Uso de operadores aritméticos, lógicos y de comparación         |    si         | Pudo haberle puesto un numero de limite a la vida del
                                                                                    guerrero.|
| Condiciones para subir de nivel, agotarse o perder una batalla |    si          | Tanto ganar las batallas como en entrenar la fuerza. |
| Validaciones de energía y límites                               |   no          | No cuenta con los limites para poder entrenar la energia. |
| Decisión del usuario sobre cuántas horas invertir por acción   |    no          | Solo con 10 entrenamientos.            |
| Uso de estructuras de control (`if`, `for`, `do-while`, etc.)   |   si          | Gracias a estas estructuras el juego funciona, dandole al
                                                                                    usuario la posibilidad de realiar multiples acciones. |

---

## 6. Retroalimentación general

- Hubiera agregado signino de comparacion para la vida del guerrero, es decir, hasta donde tiene permitido tener vida sin sobre pasar el limite establecido.  
- Establecer un limite de entrenamiento en la fuerza para no pasar facilmente al siguiente nivel.  
- Establecer vida determinada al enemigo.
-
