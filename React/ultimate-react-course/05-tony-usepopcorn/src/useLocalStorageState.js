import { useState, useEffect } from "react";

export function useLocalStorageState(initialState, key) {
  const [value, setValue] = useState(function () {
    const storedValue = localStorage.getItem(key);
    return storedValue ? JSON.parse(storedValue) : initialState;
  });

  useEffect(
    function () {
      localStorage.setItem(key, JSON.stringify(value));
    },
    [value, key]
  );

  return [value, setValue];
}


// export default function useLocalStorageState(initialState, key) {
//     const [value, setValue] = useState(() => {
//       const storedValue = localStorage.getItem(key);
//       return JSON.parse(storedValue);
//     }); 
//   //Al iniciar la APP, solo se ejecuta una vez gracias al lazy initilization
//   //Si encuentra datos, los convierte de texto JSON a un array de películas (key)

//     useEffect(() => {
//     localStorage.setItem(key, JSON.stringify(value));
//   }, [value, key]);
//   //Cada que el usuario agrega o elimina una película, y watched cambia, s eejecuta el efecto
//   return [value, setValue];
// }
