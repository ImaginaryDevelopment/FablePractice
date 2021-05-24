import { createAtom } from "./.fable/fable-library.3.1.1/Util.js";
import { printf, toText } from "./.fable/fable-library.3.1.1/String.js";
import { Grid } from '@material-ui/core'
import { ReactNode } from 'react'


export const count = createAtom(0);

export const myButton = document.querySelector(".my-button");

myButton.onclick = ((_arg1) => {
    count(count() + 1, true);
    const arg10 = count() | 0;
    myButton.innerText = toText(printf("You clicked: %i time(s)"))(arg10);
});

