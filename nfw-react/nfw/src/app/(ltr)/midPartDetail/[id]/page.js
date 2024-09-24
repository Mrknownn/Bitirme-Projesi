"use client";
import MidPartDetailPage from '../page'

const MidPartDetail = ({ params }) => {


    if (params.id)
        return <MidPartDetailPage id={params.id} />;
};

export default MidPartDetail