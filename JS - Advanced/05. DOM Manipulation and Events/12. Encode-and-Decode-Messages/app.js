function encodeAndDecodeMessages() {

    let inputTextArea = document.querySelector('textarea');
    
    let outputTextArea = document.querySelectorAll('textarea')[1];

    document.querySelector('button').addEventListener('click', function(){
        let resultText = '';
        for(let i = 0; i < inputTextArea.value.length; i++){
            let currentNum = inputTextArea.value.charCodeAt(i) + 1;
            let currentChar = String.fromCharCode(currentNum);
            resultText += currentChar;
        };
        inputTextArea.value = '';
        outputTextArea.value = resultText;
    });

    document.querySelectorAll('button')[1].addEventListener('click', function(){
        let resultText = '';
        for(let i = 0; i < outputTextArea.value.length; i++){
            let currentNum = outputTextArea.value.charCodeAt(i) - 1;
            let currentChar = String.fromCharCode(currentNum);
            resultText += currentChar;
        };
        outputTextArea.value = '';
        inputTextArea.value = resultText;
    })    



    
}