import React from "react";
import Link from "next/link";
import {NextRouter, useRouter} from "next/router";

const SideBar = ()=> {
    //Enrutando los URLS
    const router= useRouter();
    return (
        <aside className="bg-gray-800 sm:w-1/3 xl:w-1/5 sm:min-h-screen p-5"  >
            <div>
                <p className= "text-white text-2xl font-black">CRM CLIENTE</p>
            </div>
            <nav className="mt-5 list-none">
                <li className={router.pathname ==="/" ? "bg-blue-800 p-2" : "p-2"}>
                    <Link href= "/">
                        Clientes
                    </Link>
                </li>
                <li className={router.pathname ==="/pedidos" ? "bg-blue-800 p-2" : "p-2"}>
                    <Link href= "/pedidos">
                        Pedidos
                    </Link>
                </li>
                <li className={router.pathname ==="/productos" ? "bg-blue-800 p-2" : "p-2"}>
                    <Link href= "/productos">
                        Productos
                    </Link>
                </li>
            </nav>

            <div>
                <p className="text-white text-2xl font-black"> Otras opciones
                </p>
            </div>
            <nav className="mt-5 list-none">
                <li className={router.pathname ==="/mejoresvendedores" ? "bg-blue-800 p-2" : "p-2"}>
                    <Link href= "/mejoresvendedores">
                        Mejores Vendedores
                    </Link>
                </li>
                <li className={router.pathname ==="/mejoresclientes" ? "bg-blue-800 p-2" : "p-2"}>
                    <Link href= "/mejoresclientes">
                        Mejores Clientes
                    </Link>
                </li>
            </nav>

        </aside>

    );
}


export default SideBar;