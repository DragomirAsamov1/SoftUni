function validate() {
    let reg = /^[\w\-.]+@[a-z]+.{1}[a-z]{2,}$/;

    let inputElement = document.getElementById('email');

    inputElement.addEventListener('change', checkEmail);

    function checkEmail(e){
        if(reg.test(e.target.value)){
            e.target.removeAttribute('class');
            return;
        }

        e.target.className = 'error';
    }
}