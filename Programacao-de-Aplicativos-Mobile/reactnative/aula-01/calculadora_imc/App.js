import React from "react";
import { StyleSheet, Text, SafeAreaView, Image, TextInput, Button } from 'react-native';


const App = () => {
  const [number, onChangeNumber] = React.useState(null);

  return (
    <SafeAreaView style={styles.container}>
      <Image style={styles.tinyLogo} source={require('./assets/calculadora_ico.png')} />

      <TextInput
        style={styles.input}
        onChangeText={onChangeNumber}
        value={number}
        placeholder="Informe seu peso"
        keyboardType="numeric"
      />

      <TextInput
        style={styles.input}
        onChangeText={onChangeNumber}
        value={number}
        placeholder="Informe sua altura"
        keyboardType="numeric"
      />

      <Text style={styles.innerText}> </Text>

      <Button style={styles.button}
        title='CALCULAR'
        color='#563344'
        onPress={() => Alert.alert('Button with adjusted color pressed')}
      />

    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#178f6f',
    alignItems: 'center',
    justifyContent: 'center',
  },
  innerText: {
    color: '#fff',
  },
  tinyLogo: {
    width: 45,
    height: 70,
  },
  logo: {
    width: 80,
    height: 80,
  },
  input: {
    height: 40,
    width: 220,
    margin: 12,
    color: '#fff',
    placeholderTextColor: '#fff',
    borderColor: '#fff',
    borderWidth: 1,
    padding: 10,
  },
});

export default App;
