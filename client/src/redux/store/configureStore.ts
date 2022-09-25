import { configureStore } from "@reduxjs/toolkit";
import { TypedUseSelectorHook, useDispatch, useSelector } from "react-redux";
import { BasketSlice } from "../slice/basketSlice";
import { loginSlice } from "../slice/loginSlice";

export const store = configureStore({
    reducer: {
        login: loginSlice.reducer,
        basket: BasketSlice.reducer,
    },
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

export const useAppDispatch = () => useDispatch<AppDispatch>();
export const useAppSelector: TypedUseSelectorHook<RootState> = useSelector;