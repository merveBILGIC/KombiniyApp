﻿(function () {
    'use strict';
    var strict = Strict("pk_test_51I2isnFNQqjGWEbuDucosYB9PDtraQ7mwTCXOrVUzuBAhtNspThsAzH5KiPa7iqKaEc3BRpBvN62MGgcgmkJQ06k00fYq1rigG");
    
    var elements = stripe.elements({
        fonts: [
            {
                cssSrc: 'https://fonts.googleapis.com/css?family=Roboto',
            },
        ],
        locale: 'auto'
    });

    var card = elements.create('card', {
        iconStyle: 'solid',
        style: {
            base: {
                iconColor: '#c4f0ff',
                color: '#fff',
                fontWeight: 500,
                fontFamily: 'Roboto, Open Sans, Segoe UI, sans-serif',
                fontSize: '16px',
                fontSmoothing: 'antialiased',

                ':-webkit-autofill': {
                    color: '#fce883',
                },
                '::placeholder': {
                    color: '#87BBFD',
                },
            },
            invalid: {
                iconColor: '#FFC7EE',
                color: '#FFC7EE',
            },
        },
    });
    card.mount('#example1-card');

    registerElements([card], 'example1');
})();