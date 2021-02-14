import React, { Component } from 'react';

class App extends Component {
  
    constructor(props){
        super(props);
        
        this.escolha = this.aumentar.bind(this);
        
    }

    td (props){
        console.log(props.escolha);
      
    }
    escolha(props){
       
        
    }
   /* aumentar(){
        let state = this.state;
        state.contador += 1;
        this.setState(state);
    }*/

//ciclo de vida de um componente
 
   //Executa assim que o componente é montado
  /*  componentDidMount(){ 
     
        setInterval(()=>{
            this.setState({hora: new Date().toLocaleTimeString() })
        }, 1000);

    }

    componentDidUpdate(){ 
        //Executa toda vez que o componente é atualizado

    }

    shouldComponentUpdate(){
        //retorna True ou False caso você queira ou não que ele atualize

    }*/

    render (){
        return (
            <div>
               <table>
                   <tbody>
                    <tr> 
                        <td escolha="1_1">a</td>
                        <td escolha="1_2">b</td>
                        <td escolha="1_3">c</td>
                    </tr>
                    <tr>
                        <td escolha="2_1">d</td>
                        <td escolha="2_2">e</td>
                        <td escolha="2_3">f</td>
                    </tr>
                    <tr>
                        <td escolha="3_1"></td>
                        <td escolha="3_2"></td>
                        <td escolha="3_3"></td>
                    </tr>
                   </tbody>
               </table>
            </div>
        );


    }

}

export default App;

// Props sao estáticas
// e as states conseguimos trocar o valor
// sao dinamicas


/* AULA ANTERIOR */

/*

import React, { Component } from 'react';

class App extends Component {

    constructor(props){
        super(props);
        this.state = {
            nome: 'Matheus',
            contador: 0
        }
        this.aumentar = this.aumentar.bind(this);
        this.diminuir = this.diminuir.bind(this);
    }

    aumentar(){
        let state = this.state;
        state.contador += 1;
        this.setState(state);
    }

    diminuir(){
        let state = this.state;
        state.contador -= 1;
        this.setState(state);   
    }

    render (){
        return (
            <div>
               <h1>Contador</h1>
               <h3>
                   <button onClick={this.diminuir}> - </button>
                        {this.state.contador}
                    <button onClick={this.aumentar}> + </button>
                </h3>
            </div>
        );


    }

}

export default App;


*/