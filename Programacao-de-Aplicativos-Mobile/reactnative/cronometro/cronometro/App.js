import React, {useState} from "react";
import {
  View, 
  Text, 
  StyleSheet, 
  Image, 
  TouchableOpacity
} 
from 'react-native';

let timer = null;
let ss = 0;
let mm = 0;
let hh = 0;

export default function App() {
  const [numero, setNumero] = useState(0);
  const [botao, setBotao] = useState('iniciar');
  const [ultimo, setUltimo] = useState(null);

  function iniciar(){
    
    if (timer !== null){
      // Inicia o cronometro
      clearInterval(timer);
      timer = null;
      setBotao('iniciar');
    }else{
      // Inicia o cronometro
      timer = setInterval(()=>{
        ss++;
        if(ss == 60){
          ss = 0;
          mm++;
        }
        if(mm == 60){
          mm = 0;
          hh++;
        }

        let format = (hh < 10 ? '0' + hh : hh) + ':'
        + (mm < 10 ? '0' + mm : mm) + ':'
        + (ss < 10 ? 'timer0' + ss : ss);

        setNumero(format);
      }, 1000);

      setBotao('parar');

    }
  }

  function limpar(){
    if(timer !== null){
      // Para o contador
      clearInterval(timer)
      timer = null;
    }

    setUltimo(numero);
    setNumero(0);
    ss = 0;
    mm = 0;
    hh = 0;
    setBotao('iniciar');
  }
  return (
    <View style={styles.container}>
      <Image source={require('./assets/crono.png')}/>

      <Text style={styles.timer}>{numero}</Text>

      <View style={styles.btnArea}>
        <TouchableOpacity style={styles.btn} onPress={iniciar}>
          <Text style={styles.btnText}>{botao}</Text>
        </TouchableOpacity>

        <TouchableOpacity style={styles.btn} onPress={limpar}>
          <Text style={styles.btnText}>Limpar</Text>
        </TouchableOpacity>
      </View>
    </View>
  )
}
