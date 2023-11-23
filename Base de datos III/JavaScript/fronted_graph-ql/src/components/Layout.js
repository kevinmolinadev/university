import React from "react";
import Head from "next/head";
import SideBar from "./SideBar";
const Layaout = ({ children }) => {
    return (
        <>
            <Head>
                <title>CRM - ADM CLIENTES</title>
            </Head>
            <div className="flex items-center">
                <SideBar />
                {children}
            </div>
        </>
    );
}

export default Layaout;