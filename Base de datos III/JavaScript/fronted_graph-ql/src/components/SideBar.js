import React from "react";
import Link from "next/link";
import { useRouter} from "next/router";

const SideBar = ()=> {
    //Enrutando los URLs
    const router = useRouter();
    return (
        <aside className="bg-gray-800  sm:w-1/3 xl:w-1/5 sm:min-h-screen p-5">
            <div>
                <p className= "text-white text-2xl font-black">CRM CLIENTES</p>
            </div>
            <nav className="mt-5 list-none">
                <li className={router.pathname ==="/" ? "bg-blue-800 p-2" : "p-2"}>
                    <Link className="text-white" href="/">
                        Clientes
                    </Link>
                </li>
                <li className={router.pathname ==="/orders" ? "bg-blue-800 p-2" : "p-2"}>
                    <Link className="text-white" href="/orders">
                        Pedidos
                    </Link>
                </li>
                <li className={router.pathname ==="/products" ? "bg-blue-800 p-2" : "p-2"}>
                    <Link className="text-white" href="/products">
                        Productos
                    </Link>
                </li>
            </nav>

            <div>
                <p className="text-white text-2xl font-black">Otras opciones</p>
            </div>
            <nav className="mt-5 list-none">
                <li className={router.pathname ==="/bestsellers" ? "bg-blue-800 p-2" : "p-2"}>
                    <Link className="text-white" href="/bestsellers">
                        Mejores Vendedores
                    </Link>
                </li>
            </nav>


        </aside>

    );
}

export default SideBar;