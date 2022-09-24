import React, {useEffect, useState} from "react";
import agent from "../actions/agent";
import { Basket } from "../models/basket";

const BasketPage = () => {
    const [items, setItem] = useState<Basket>();

    useEffect(() => {
        agent.Baskets.get().then((response) => {
            setItem(response);
        })
    }, []);
    return <>
        <h1>{items?.clientId}</h1>
    </>
};

export default BasketPage;