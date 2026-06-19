# \# UE\_InteractiveShow

Este repositorio contiene todas las escenas creadas en Unreal Engine para el proyecto InteractiveShow.

Incluye blueprints, materiales, secuencias y lógica de interacción.



\## 🌟 Qué contiene este repositorio

* Escenas completas renderizadas

  * Escenas de transicion, las principales, etc.
* Blueprints de interacción
* Controladores de loops (acierto/fallo)
* Señales visuales y triggers
* Secuencias de cámara
* Materiales básicos y placeholders
* Carpeta de storyboards y referencias



\## 🎬 Escenas incluidas en esta build

/train-scene

/contest-scene

/weather-scene

/west-duel-scene

(El resto quedan fuera de esta versión por tiempo.)



\## 🧩 Estructura

```

/scenes

&#x20;   /main-scene

&#x20;   /train-scene

&#x20;   /news-scene

&#x20;   /contest-scene

&#x20;   /studio-scene



/blueprints

&#x20;   InteractionManager

&#x20;   LoopController

&#x20;   SceneTriggers



/sequences

/materials

/docs

/videos\_previews

```



\## 🔄 Lógica de interacción

Cada escena incluye:

* Momento interactivo definido por un trigger
* Ventana de input (tiempo limitado)
* Resultado
* Acierto
* Fallo
* Marcadores de transición para exportar a vídeo



\## 🎥 Exportación

Las escenas se exportan como vídeo con:

* Marcadores de inicio/fin de interacción
* Escena de fallo + acierto
* Continuación de acierto
* Transición final
* Estos marcadores se usan luego en el reproductor web.

\-------

📜 Licencia

Código: MIT

Arte y vídeo: CC‑BY‑NC

\----------



